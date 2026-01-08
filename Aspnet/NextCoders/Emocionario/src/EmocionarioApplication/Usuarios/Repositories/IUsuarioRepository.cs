using EmocionarioDomain;
using EmocionarioDomain.Usuarios.ValueObjects;

namespace EmocionarioApplication.Usuarios.Repositories
{
    //Se eu estiver certo, esse arquivo serve para dizer/definir os contratos ou implementações que o repositório de usuários deve seguir.
    public interface IUsuarioRepository
    {
    Task<bool> ExisteComEmailAsync(Email email, CancellationToken cancellationToken = default);
    Task AdicionarAsync(Usuario usuario, CancellationToken cancellationToken = default);
    Task<Usuario?> ObterPorIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Usuario?> ObterPorEmailAsync(Email email, CancellationToken cancellationToken = default);
    Task AtualizarAsync(Usuario usuario, CancellationToken cancellationToken = default);
    Task<bool> ExcluirAsync(Guid id, CancellationToken cancellationToken = default);
            
    }
}