# api-conformidade-facil
Acessando a API de integração do projeto Conformidade Fácil com certificado digital em C#

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como acessar a API de integração do projeto Conformidade Fácil com certificado digital em C#.

A nova API do projeto Conformidade Fácil já está no ar e disponível para consumo. A primeira interface pública e gratuita da API permite a integração de sistemas com as tabelas e definições das codificações relacionadas à legislação do IBS e CBS.

O acesso via autenticação mútua com certificado digital ICP-Brasil.

A recomendação é não realizar chamadas em loop - um GET diário por empresa é suficiente.

>Endpoint: https://cff.svrs.rs.gov.br/api/v1/consultas/classTrib

>Resposta: JSON

>Conexão: TLS 1.2

<div align="center">
    <img src="https://github.com/user-attachments/assets/2f3970f3-6c14-4028-ad84-12ae93a7d043"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x509certificateloader?view=net-10.0

https://dfe-portal.svrs.rs.gov.br/Cff

## Licença
GPL-3.0 license
