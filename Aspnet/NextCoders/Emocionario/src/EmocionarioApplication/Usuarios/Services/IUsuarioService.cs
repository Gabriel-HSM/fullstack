using EmocionarioApplication.Usuarios.DTOs;

namespace EmocionarioApplication.Usuarios.Services

/// <summary>
/// Define o contrato para operações de negócio relacionadas a usuários.
/// Implementa o padrão Service Layer, orquestrando operações entre DTOs, domínio e repositório.
/// </summary>
/// <remarks>
/// Este serviço é responsável por:
/// - Validar regras de negócio (como unicidade de e-mail)
/// - Converter DTOs em entidades de domínio e vice-versa
/// - Orquestrar operações entre a camada de apresentação e o domínio
/// - Garantir que as operações de domínio sejam executadas de forma consistente
/// - Fornecer uma API orientada a DTOs para a camada de apresentação/API
/// </remarks>

{
    public interface IUsuarioService
    {
        /// <summary>
    /// Cria um novo usuário no sistema.
    /// </summary>
    /// <param name="dto">DTO contendo os dados do usuário a ser criado.</param>
    /// <param name="cancellationToken">Token para cancelamento da operação assíncrona.</param>
    /// <returns>
    /// Uma task que representa a operação assíncrona.
    /// O resultado contém o DTO do usuário criado, incluindo o ID gerado.
    /// </returns>
    /// <exception cref="InvalidOperationException">
    /// Lançada quando já existe um usuário cadastrado com o e-mail fornecido.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// Lançada quando os dados do DTO violam as regras de validação dos Value Objects
    /// (ex: nome muito curto, e-mail inválido, data de nascimento futura).
    /// </exception>
    /// <remarks>
    /// Este método:
    /// - Valida a unicidade do e-mail antes de criar o usuário
    /// - Converte strings do DTO em Value Objects do domínio
    /// - Utiliza o Factory Method Usuario.Criar() para garantir criação válida
    /// - Retorna o usuário criado com todas as propriedades, incluindo CriadoEm
    /// </remarks>
    
        Task<UsuarioDto> CriarAsync(CriarUsuarioDto criarUsuarioDto, CancellationToken cancellationToken = default);
        Task<UsuarioDto> ObterPorIdAsync(Guid Id, CancellationToken cancellationToken = default);
        Task<UsuarioDto> ObterPorEmailAsync(string Email, CancellationToken cancellationToken = default);
        Task<bool> AtualizarAsync(AtualizarUsuarioDto atualizarUsuarioDto, CancellationToken cancellationToken = default);
        Task<bool> ExcluirAsync(Guid Id, CancellationToken cancellationToken = default);

    }
}