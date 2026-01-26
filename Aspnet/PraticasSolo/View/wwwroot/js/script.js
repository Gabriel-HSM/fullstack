//Adiciona os filtros selecionado na div de filtros selecionados
if(document.getElementById('filtro-dropdown')){
    document.getElementById('filtro-dropdown').addEventListener('submit', function(evento){
        evento.preventDefault();
    
        const filtros = new FormData(evento.target);
        const filtrosSelecionadosDiv = document.getElementById('filtros-selecionados');
    
        //limpa os filtros antes de adicionar
        filtrosSelecionadosDiv.innerHTML = '';
    
        filtros.getAll('filtrosAdd[]').forEach(filtro => {
            filtrosSelecionadosDiv.innerHTML += 
                `
                <button id="btn-${filtro}" class="btn btn-sm rounded-4 d-flex align-items-center border-2 size-150h ms-1 my-1" style="background-color: var(--CorBase3); color: var(--CorFontePadrao); border-color: var(--CorBase1);">
                    ${filtro}
                </button>
                `;
        });
    
    })
}
    
//Remove os filtros selecionados da div e dos checkboxes
document.querySelectorAll("#filtros-remove").forEach(function(element){
    element.addEventListener('click', function(evento){
        evento.preventDefault();

        const filtrosSelecionadosDiv = document.getElementById('filtros-selecionados');
        filtrosSelecionadosDiv.innerHTML = '';

        checkboxes = document.querySelectorAll('#filtro-dropdown input[type="checkbox"]');
        checkboxes.forEach(checkbox => checkbox.checked = false);

    })
})

//Pega o valor do item clicado pela classe 'items' e expande a div para mostrar mais informações
document.querySelectorAll('.items').forEach(function(element){
    element.addEventListener('click', function(){

        //CONTAINER DO ITEM CLICADO
        const item = this;
        //PASSADO POR DATA ID LÀ NA VIEW
        const itemId = item.dataset.id;

        

        if(!item) return;

        if (item.classList.contains('item-expandido')){
            //Fecha o item
            item.classList.remove('item-expandido');
        }

            item.classList.toggle('item-expandido');

            //animação de abertura
            item.classList.remove('item-abrir');
            item.offsetWidth; // Força o reflow
            item.classList.add('item-abrir');

            //Texto nome do objeto e preço ao lado do outro
            const nomeEPreco = item.querySelector('.itemNomeEPreco');
            if (!nomeEPreco) return;
            nomeEPreco.classList.add('d-flex', 'gap-1');

            //Div dinamica de mais informações
            const itemDetalhesDinamicos = item.querySelector('.detalhes-dinamicos')

            //Itens do texto dinâmico
            const nome = item.dataset.nome;
            const preco = item.dataset.preco;
            const marca = item.dataset.marca;
            const ano = item.dataset.ano;
            const chassis = item.dataset.chassis;
            const primeiraAparicao = item.dataset.primeiraAparicao;
            const ipva = item.dataset.ipva;
            const unidadesMundo = item.dataset.unidades;
            const curiosidade = item.dataset.curiosidade;
            const pais = item.dataset.pais;
            const motor = item.dataset.motor;


            itemDetalhesDinamicos.classList.add('itemText');
            itemDetalhesDinamicos.innerHTML = `
                <p class="m-0">${nome} foi fabricado no ano ${ano} custando cerca de R$ ${parseFloat(preco).toLocaleString('pt-BR', {style: 'currency', currency: 'BRL'})}, possui o chassis do tipo ${chassis}, o responsável pela sua fabricado foi a(o) ${marca}. Sua primeira aparição foi em ${primeiraAparicao}.
                No Brasil seu IPVA mais caro custa cerca de R$ ${parseFloat(ipva).toLocaleString('pt-BR', {style: 'currency', currency: 'BRL'})} e possui ${unidadesMundo} fabricadas. Ele foi fabricado no(a) ${pais} e possui um motor do tipo ${motor}.
                </p>
                <br/>
                <p class="mt-3 bold">
                CURIOSIDADES: ${curiosidade}
                </p>
            `;

            //Botões de ação deletar, editar e fechar voltando ao tamanho ao original
            if (!item.querySelector('.conteudoBotaoFechar') && !item.querySelector('.conteudoBotaoEditar') && !item.querySelector('.conteudoBotaoDeletar')) {
                const botaoFechar = document.createElement('button');
                const botaoEditar = document.createElement('button');
                const botaoDeletar = document.createElement('button');

                //Botão FECHAR
                botaoFechar.className = 'conteudoBotaoFechar btn btn-small d-flex align-items-center justify-content-center';
                botaoFechar.innerHTML = '<i class="fa-regular fa-circle-xmark"></i>';

                //Botão EDITAR
                botaoEditar.className = 'conteudoBotaoEditar btn btn-small d-flex align-items-center justify-content-center';
                botaoEditar.innerHTML = '<i class="fa-regular fa-pen-to-square"></i>';

                //Botão DELETAR
                botaoDeletar.className = 'conteudoBotaoDeletar btn btn-small d-flex align-items-center justify-content-center';
                botaoDeletar.innerHTML = '<i class="fa-regular fa-trash-can"></i>';

                const detalhes = item.querySelector('.detalhes-dinamicos');

                //Ação de fechar a div
                botaoFechar.addEventListener('click', function (e) {
                    e.stopPropagation();

                    item.classList.remove('item-expandido');
                    if (typeof nomeEPreco !== 'undefined' && nomeEPreco) nomeEPreco.classList.remove('d-flex', 'gap-1');
                    if (detalhes) {
                        detalhes.innerHTML = '';
                        detalhes.classList.remove('itemText');
                    }
                    this.remove();
                });

                //Ação de editar o item
                botaoEditar.addEventListener('click', function (e) {
                    e.stopPropagation();

                    fetch(`/Carro/Edit?id=${itemId}`,{
                        method: 'GET',
                    })
                    .then(response => {
                        if (response.ok) {
                            window.location.href = `/Carro/Edit?id=${itemId}`;
                        } else {
                            alert('Erro ao carregar a página de edição.');
                        }
                    })

                });

                //Ação de excluir o item
                botaoDeletar.addEventListener('click', function (e) {
                    e.stopPropagation();

                    const confirmacao = confirm('Tem certeza que deseja deletar este item?');
                    

                    if (confirmacao){
                        fetch(`/Carro/Delete?id=${itemId}`, {
                            method: 'DELETE',
                        })
                        .then(response => {
                            if (response.ok) {
                                alert('Item deletado com sucesso!');
                                item.remove();
                            }
                        })  
                    }
                });

                if (detalhes) {
                    detalhes.appendChild(botaoFechar);
                    detalhes.appendChild(botaoEditar);
                    detalhes.appendChild(botaoDeletar);
                }
            }

        // move pro topo
        item.parentElement.prepend(item);
    });
});
    
//Preview da imagem selecionada no formulário de criação de carro
const divImagemPreview = document.getElementById('imagemPreview');
const inputImagem = document.getElementById('imagemInput');

if (inputImagem) {
    inputImagem.addEventListener('change', function(){
        const arquivo = this.files[0];

        if (!arquivo)return;

        const leitor = new FileReader();

        leitor.onload = function(e){
            divImagemPreview.src = e.target.result;
            divImagemPreview.style.display = 'block';
        };
        leitor.readAsDataURL(arquivo);
    })
}