# Product Service (Produtos)
Este microserviço gerencia o catálogo de produtos e controle de estoque, além de receber atualizações de pedidos via RabbitMQ.
##
🚀 Tecnologias Utilizadas <br>
.NET 8 <br>
RabbitMQ <br>
MySQL <br>
Entity Framework Core <br>
Docker <br><br>
##
📌 Funcionalidades
Gerenciar Produtos: Criar, atualizar e listar produtos no catálogo.
Consultar Estoque: Verificar a disponibilidade de produtos.
Atualizar Estoque: Reduzir a quantidade disponível após um pedido.
Notificação de Atualização: Enviar eventos via RabbitMQ para outros microserviços.
