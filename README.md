Processo Seletivo - Teste prático



**Tecnologias utilizadas:**

| DataBase                                                     | Back-End                                                     | Front-End                                                    | Container                                                    | GIT                                                          |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| ![](https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-plain.svg) | ![](https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg) | ![](https://cdn.jsdelivr.net/gh/devicons/devicon/icons/angularjs/angularjs-original.svg) | ![](https://cdn.jsdelivr.net/gh/devicons/devicon/icons/docker/docker-original-wordmark.svg) | ![](https://cdn.jsdelivr.net/gh/devicons/devicon/icons/github/github-original.svg) |
| SQL Server                                                   | NET Core (C#)                                                | Angular                                                      | Docker                                                       | GitHub                                                       |



Link das imagens Docker:

**SQL Server**

```
docker pull mcr.microsoft.com/mssql/server
```



**API**

```
docker pull betofrs/api
```



------



**Execução da imagem do SQL:**

```
docker run -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=a1b2c3d4e5' -p 1433:1433 --name DBCompugraf -d mcr.microsoft.com/mssql/server:latest
```







#### Screenshots:

<img src="Screens\API-Swagger.png" style="zoom:100%;" />

> Screenshot do Swagger ( API )

------



<img src="Screens\DockerHub.png" style="zoom:100%;" />

> Screenshot da API criada e disponibilizada no DockerHub.

------
<br>
<br>


<img src="Screens\Docker.png" style="zoom:100%;" />

> Screenshot do Docker com os 2 containers em execução.

------
<br>
<br>


<img src="Screens\Front.png" style="zoom:100%;" />

> Screenshot da tela do Front ( Home ).

------
<br>
<br>


<img src="Screens\Inclusão.png" style="zoom:100%;" />

> Screenshot da tela de Incluir.
------
<br>
<br>

<img src="Screens\Listar.png" style="zoom:100%;" />

> Screenshot da tela de listagem.

