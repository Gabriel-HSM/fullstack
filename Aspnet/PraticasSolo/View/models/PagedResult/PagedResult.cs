namespace View.models.PagedResult
{
    public class PagedResult<T>
    {
        public List<T> Itens { get; set; } = new();
        public int TotalItens { get; set; }
        public int PaginaAtual { get; set; }
        public int PaginaTamanho { get; set; }

        public int TotalPaginas => 
            (int)Math.Ceiling(TotalItens / (double)PaginaTamanho);
    }
}