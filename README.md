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



![](Screens\DockerHub.png)

> Screenshot da API criada e disponibilizada no DockerHub.

------



![](Screens\Docker.png)

> Screenshot do Docker com os 2 containers em execução.

------



![](Screens\Front.png)

> Screenshot da tela do Front ( Home ).

------



![](Screens\Inclusão.png)

> Screenshot da tela de Incluir.



![](Screens\Listar.png)

> Screenshot da tela de listagem.

