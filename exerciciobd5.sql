create database exerciciobd5; 
--go
use exerciciobd5;

create table setores (
id int primary key  identity,
nome_setor varchar(255),
descricao text 
);


create table salas (
id int primary key identity,
nome_sala varchar(255),
setor_id int foreign key references setores (id),
capacidade int
);

create table alunos (
id int primary key identity,
nome varchar(255),
matricula varchar(255)
); 

create table sala_tem_alunos(
id int primary key identity,
sala_id int foreign key references salas (id),
aluno_id int foreign key references alunos (id)
);

select alunos.id, matricula, nome, nome_sala, setores.nome_setor from alunos 
inner join sala_tem_alunos on sala_tem_alunos.aluno_id = alunos.id 
inner join salas on salas.id = sala_tem_alunos.sala_id
inner join setores on setores.id = salas.setor_id
where setores.nome_setor = 'NIT';

insert into setores (nome_setor, descricao) values ('NIT','Setor das escadas até ceu'); 
insert into salas (nome_sala, setor_id, capacidade) values ('Lab.9', 1, 20);
insert into alunos (nome, matricula) values ('José Leandro dos Santos', '201014010390');
insert into sala_tem_alunos (sala_id, aluno_id) values (1,1);

select salas.id, nome_sala, capacidade, nome_setor from salas inner join setores on setores.id = setor_id;
select * from setores where nome_setor = 'NIT';