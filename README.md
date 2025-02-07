# Product Service (Produtos) - Ainda em desenvolvimento
Este microserviço gerencia o catálogo de produtos e controle de estoque, além de receber atualizações de pedidos via RabbitMQ.
##
## 🚀 Tecnologias Utilizadas <br>
.NET 8 <br>
RabbitMQ <br>
MySQL <br>
Entity Framework Core <br>
Docker <br>
##
## 📌 Funcionalidades <br>
Gerenciar Produtos: Criar, atualizar e listar produtos no catálogo.<br>
Consultar Estoque: Verificar a disponibilidade de produtos.<br>
Atualizar Estoque: Reduzir a quantidade disponível após um pedido.<br>
Notificação de Atualização: Enviar eventos via RabbitMQ para outros microserviços.<br>
