Definir uma política de execução
```
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope LocalMachine
```
Após a execução será necessária selecionar a opção desejada.
[S] Sim  [A] Sim para Todos  [N] Não  [T] Não para Todos  [U] Suspender  [?] Ajuda (o padrão é "N"): S

Use o cmdlet Install-Module para instalar o Az Módulo PowerShell
```
Install-Module -Name Az -Scope CurrentUser -Repository PSGallery -Force
```


Após as configurações da police digite o comando abaixo para conectar no azure.
 ```
 Connect-AzAccount
 ```
