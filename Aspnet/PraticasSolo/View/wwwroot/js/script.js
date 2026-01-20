//Adiciona os filtros selecionado na div de filtros selecionados
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

                const itemSelecionado = this.closest('[value]');
                if(!itemSelecionado) return;

                    console.log(itemSelecionado.getAttribute('value'));

                    item = document.getElementById(itemSelecionado.getAttribute('value'));
                    item.classList.toggle('item-expandido');

                    //animação de abertura
                    item.classList.remove('item-abrir');
                    item.offsetWidth; // Força o reflow
                    item.classList.add('item-abrir');

                    //Texto nome do objeto e preço
                    const nomeEPreco = item.querySelector('div');
                    nomeEPreco.classList.add('d-flex', 'gap-1');

                    //Div dinamica de mais informações
                    const itemDetalhesDinamicos = document.querySelector(`#${itemSelecionado.getAttribute('value')}-detalhesDinamicos`);
                    itemDetalhesDinamicos.classList.add('itemText');
                    itemDetalhesDinamicos.innerHTML = `
                        <p class="m-0">Nome do carro ano xxxx chasis xxxxxxyyy fabricado por xxxxxxxxxxxxxx. Primeira aparição foi em xxxx no não sei o que. Quem pode ter é assim e assado, IPVA é x e y no país de origem (xxxx IPVA é de xy), mas no Brasil é assim e assado. X unidade no mundo.

                        curisosidade: lampada tal som tal não sei 
                        o que lá valor x e y </p>
                    `;

                    //Botão que fecha a div
                    const botaoFechar = document.createElement('button');
                    botaoFechar.id = `btn-fechar-${itemSelecionado.getAttribute('value')}`;
                    botaoFechar.classList.add('conteudoBotaoFechar','btn','btn-small', 'd-flex','align-items-center', 'justify-content-center');
                    botaoFechar.innerHTML = '<i class="fa-regular fa-circle-xmark"></i>';

                    // Verifica se o botão já existe antes de criá-lo
                    const existeBotao = document.getElementById(`btn-fechar-${itemSelecionado.getAttribute('value')}`);
                    if (!existeBotao) {
                        itemDetalhesDinamicos.appendChild(botaoFechar);
                    }

                    //Ação de fechar a div
                    botaoFechar.addEventListener('click', function(e){
                        e.stopPropagation();

                        const itemId = itemSelecionado.getAttribute('value');
                        const itemVoltarTamanhoNormal = document.getElementById(itemId);
                        const itemDetalhesDinamicosFechar = document.querySelector(`#${itemId}-detalhesDinamicos`);

                        itemVoltarTamanhoNormal.classList.remove('item-expandido');
                        itemVoltarTamanhoNormal.classList.add('items');

                        nomeEPreco.classList.remove('d-flex', 'gap-1');

                        itemDetalhesDinamicosFechar.innerHTML = '';
                        itemDetalhesDinamicosFechar.classList.remove('itemText');
                        botaoFechar.innerHTML = '';
                    });

                    //Move o item para o começo da lista
                    const container = item.parentElement;
                    container.prepend(item);

            });
        });