using EmocionarioApplication.Usuarios.DTOs;

namespace EmocionarioApplication.Usuarios.Services
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> CriarAsync(CriarUsuarioDto criarUsuarioDto, CancellationToken cancellationToken = default);
        Task<UsuarioDto> ObterPorIdAsync(Guid Id, CancellationToken cancellationToken = default);
        Task<UsuarioDto> ObterPorEmailAsync(string Email, CancellationToken cancellationToken = default);
        Task<bool> AtualizarAsync(AtualizarUsuarioDto atualizarUsuarioDto, CancellationToken cancellationToken = default);
        Task<bool> ExcluirAsync(Guid Id, CancellationToken cancellationToken = default);

    }
}