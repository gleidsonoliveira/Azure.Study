Definir uma política de execução
```
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope LocalMachine
```
Após a execução será necessária selecionar a opção desejada.
[S] Sim  [A] Sim para Todos  [N] Não  [T] Não para Todos  [U] Suspender  [?] Ajuda (o padrão é "N"): S

Use o cmdlet Install-Module para instalar o Az Módulo PowerShell
```
Install-Module -Name Az -Scope CurrentUser -Repository PSGallery -Force ou  Install-Module Az (Selecionar A para instalar tudo).

```
Fonte: https://learn.microsoft.com/bs-latn-ba/powershell/azure/install-azps-windows?view=azps-10.4.1&tabs=powershell&pivots=windows-psgallery

Após as configurações da police digite o comando abaixo para conectar no azure.
```
Login-AzAccount - Esse comando invoca a tela de login do azure.
```
```
Logout-AzAccount - Esse comando realiza o logout na conta do azure.
```
Seleciona a 
```
Get-Azlocation |select Location
```



