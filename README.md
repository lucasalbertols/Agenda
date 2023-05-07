# Lista de tarefas | Integrando Banco de Dados

Projeto desenvolvido para integrar taferas realizadas e armazenadas em um banco de dados.

## 📋 Requisitos

A aplicação deve ter um modelo Task com as seguintes propriedades:<br/>
Id (int): identificador único da tarefa.<br/>
Description (string): descrição da tarefa.<br/>
IsCompleted (bool): indica se a tarefa está concluída ou não.<br/>
A aplicação deve permitir adicionar uma nova tarefa à lista, informando sua descrição. A 
tarefa deve ser adicionada ao banco de dados com o status "não concluída" e com um 
Id único.

A aplicação deve permitir remover uma tarefa da lista, informando o Id da tarefa a ser 
removida.

A aplicação deve permitir listar todas as tarefas cadastradas no banco de dados, 
mostrando o Id, a descrição e o status de cada tarefa.

A aplicação deve permitir atualizar o status de uma tarefa para concluída, informando o 
Id da tarefa a ser atualizada. A tarefa deve ser marcada como concluída no banco de 
dados.

A aplicação deve tratar possíveis exceções, como por exemplo a tentativa de remover 
uma tarefa que não existe.

### 🔧 Tecnologias utilizadas

* .Net 6
* Entity Framework Core
* Asp.Net MVC
* SQLite
