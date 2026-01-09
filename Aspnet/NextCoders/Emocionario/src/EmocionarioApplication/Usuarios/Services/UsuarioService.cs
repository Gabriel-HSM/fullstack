using EmocionarioApplication.Usuarios.DTOs;
using EmocionarioApplication.Usuarios.Repositories;
using EmocionarioDomain;
using EmocionarioDomain.Usuarios.ValueObjects;

namespace EmocionarioApplication.Usuarios.Services
{

    /// <summary>
/// Implementação do serviço de aplicação para operações relacionadas a usuários.
/// Orquestra a interação entre DTOs, entidades de domínio e o repositório.
/// </summary>
/// <remarks>
/// Esta classe implementa a camada de aplicação seguindo os princípios de Clean Architecture:
/// - Converte DTOs (dados primitivos) em Value Objects e Entidades de domínio
/// - Aplica regras de negócio da aplicação (como validação de unicidade de e-mail)
/// - Delega operações de persistência para o repositório
/// - Mantém a separação entre a camada de apresentação e o domínio
/// - Utiliza o padrão sealed para prevenir herança indesejada
/// </remarks>

    public sealed class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioDto> CriarAsync(CriarUsuarioDto criarUsuarioDto, CancellationToken cancellationToken = default)
        {
            var email = new Email(criarUsuarioDto.Email);

            if(await _usuarioRepository.ExisteComEmailAsync(email, cancellationToken))
            {
                throw new InvalidOperationException($"Já existe um usuário cadastrado com o email '{criarUsuarioDto.Email}'.");
            }

            var nome = new PrimeiroNome(criarUsuarioDto.Nome);
            var sobrenome = new Sobrenome(criarUsuarioDto.Sobrenome);
            DataNascimento? dataNascimento = criarUsuarioDto.DataNascimento.HasValue
            ? new DataNascimento(criarUsuarioDto.DataNascimento.Value)
            : null;

            var usuario = Usuario.Criar(nome, sobrenome, email, dataNascimento);

            await _usuarioRepository.AdicionarAsync(usuario, cancellationToken);

            return MapearParaDto(usuario);
        }

        public async Task<UsuarioDto?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(id, cancellationToken);
            return usuario is not null ? MapearParaDto(usuario) : null;
        }

        public async Task<UsuarioDto?> ObterPorEmailAsync(string email, CancellationToken cancellationToken = default)
        {
            var emailVo = new Email(email);
            var usuario = await _usuarioRepository.ObterPorEmailAsync(emailVo, cancellationToken);
            return usuario is not null ? MapearParaDto(usuario) : null;
        }

        public async Task<bool> AtualizarAsync(AtualizarUsuarioDto dto, CancellationToken cancellationToken = default)
        {
            var usuario = await _usuarioRepository.ObterPorIdAsync(dto.Id, cancellationToken);

            if (usuario is null)
                return false;

            var nome = !string.IsNullOrWhiteSpace(dto.Nome)
                ? new PrimeiroNome(dto.Nome)
                : usuario.Nome;

            var sobrenome = !string.IsNullOrWhiteSpace(dto.Sobrenome)
                ? new Sobrenome(dto.Sobrenome)
                : usuario.Sobrenome;

            DataNascimento? dataNascimento = dto.DataNascimento.HasValue
                ? new DataNascimento(dto.DataNascimento.Value)
                : usuario.DataNascimento;

            usuario.Atualizar(nome, sobrenome, dataNascimento);

            await _usuarioRepository.AtualizarAsync(usuario, cancellationToken);

            return true;
        }

        public async Task<bool> ExcluirAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _usuarioRepository.ExcluirAsync(id, cancellationToken);
        }


        private static UsuarioDto MapearParaDto(Usuario usuario)
        {
            return new UsuarioDto
            {
                Id = usuario.Id,
                Nome = usuario.Nome,
                Sobrenome = usuario.Sobrenome,
                Email = usuario.Email,
                DataNascimento = usuario.DataNascimento?.Valor,
                DataCriacao = usuario.DataCriacao,
                DataAtualizacao = usuario.DataAtualizacao
            };
        }
    }
}