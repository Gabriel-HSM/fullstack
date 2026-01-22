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

                const item = this;
                const itemId = this.id;

                if(!item) return;


                    item.classList.toggle('item-expandido');

                    //animação de abertura
                    item.classList.remove('item-abrir');
                    item.offsetWidth; // Força o reflow
                    item.classList.add('item-abrir');

                    //Texto nome do objeto e preço
                    const nomeEPreco = item.querySelector('.itemNomeEPreco');
                    if (!nomeEPreco) return;
                    nomeEPreco.classList.add('d-flex', 'gap-1');

                    //Div dinamica de mais informações
                    const itemDetalhesDinamicos = item.querySelector('.detalhes-dinamicos')
                    itemDetalhesDinamicos.classList.add('itemText');
                    itemDetalhesDinamicos.innerHTML = `
                        <p class="m-0">Nome do carro ano xxxx chasis xxxxxxyyy fabricado por xxxxxxxxxxxxxx. Primeira aparição foi em xxxx no não sei o que. Quem pode ter é assim e assado, IPVA é x e y no país de origem (xxxx IPVA é de xy), mas no Brasil é assim e assado. X unidade no mundo.

                        curisosidade: lampada tal som tal não sei 
                        o que lá valor x e y </p>
                    `;

                    //Botão que fecha a div
                    if (!item.querySelector('.conteudoBotaoFechar')) {
                        const botaoFechar = document.createElement('button');
                        botaoFechar.className = 'conteudoBotaoFechar btn btn-small d-flex align-items-center justify-content-center';
                        botaoFechar.innerHTML = '<i class="fa-regular fa-circle-xmark"></i>';

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

                        if (detalhes) detalhes.appendChild(botaoFechar);
                    }

                // move pro topo
                item.parentElement.prepend(item);
            });
        });