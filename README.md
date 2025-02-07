Order Service (Faturamento)
Este microserviço gerencia o processamento de pedidos, integração com o estoque e comunicação via RabbitMQ.

🚀 Tecnologias Utilizadas
.NET 8
RabbitMQ
MySQL
Entity Framework Core
Docker
📌 Funcionalidades
Criar Pedido: Recebe pedidos via API e publica mensagens no RabbitMQ.
Validar Estoque: Consulta o Microserviço de Produtos para verificar a disponibilidade.
Atualizar Estoque: Envia uma solicitação ao Microserviço de Produtos para reduzir a quantidade disponível.
Confirmar Pedido: Atualiza o status do pedido e armazena no histórico.
Histórico de Pedidos: Permite consultar pedidos já processados.
