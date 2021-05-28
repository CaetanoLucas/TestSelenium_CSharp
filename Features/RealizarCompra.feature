#language: pt

Funcionalidade: Realizar compra. 
Eu como usuário, desejo consultar produtos,
adicionar no carrinho e percorrer passos até gerar ordem. 

Cenário: Gerar ordem
Dado que eu acesse o site my store
Quando eu procurar por um produto
E adicionar este produto no carrinho
E efetuar login
E confirmar o endereço
E aceitar os termos
E escolher a forma de pagamento
Então o site retorna a ordem completa