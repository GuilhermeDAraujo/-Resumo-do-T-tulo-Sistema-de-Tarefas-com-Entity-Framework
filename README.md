# Gerenciador de Tarefas

Este é um projeto de um sistema gerenciador de tarefas, desenvolvido como parte do desafio de projeto da trilha .NET da DIO. A ideia é criar uma aplicação que ajude a organizar 
uma lista de tarefas.

## Contexto

A aplicação permite criar, ler, atualizar e deletar tarefas (CRUD). Pode ser uma Web API ou MVC, conforme a preferência.

## Estrutura da Classe Tarefa

Tarefa
├── id: int
├── titulo: string
├── descricao: string
├── data: DateTime
└── status: string

Endpoints
Aqui estão os endpoints da aplicação:

Verbo	Endpoint	Parâmetro	
GET	/Tarefa/{id}	id	
PUT	/Tarefa/{id}	id	
DELETE	/Tarefa/{id}	
GET	/Tarefa/ObterTodos	
GET	/Tarefa/ObterPorTitulo	titulo
GET	/Tarefa/ObterPorData	data	
GET	/Tarefa/ObterPorStatus	status
POST	/Tarefa	N/A	Schema Tarefa
