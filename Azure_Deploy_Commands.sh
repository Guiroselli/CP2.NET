
# Login (se necessário)
az login

# Criar grupo de recursos
az group create --name MapeamentoPatioRG --location eastus

# Criar plano de serviço App Service para container Linux
az appservice plan create --name MapeamentoPatioPlan --resource-group MapeamentoPatioRG --sku B1 --is-linux

# Criar Web App com imagem Docker (ajuste o nome para um nome único)
az webapp create --resource-group MapeamentoPatioRG --plan MapeamentoPatioPlan --name mapeamentopatioapi2025 --deployment-container-image-name SEUNOME/mapepatio:latest

# Configurar porta e variáveis de ambiente
az webapp config appsettings set --resource-group MapeamentoPatioRG --name mapeamentopatioapi2025 --settings WEBSITES_PORT=80

# Configurar logs
az webapp log config --name mapeamentopatioapi2025 --resource-group MapeamentoPatioRG --docker-container-logging filesystem

# Ver endereço do app
az webapp show --resource-group MapeamentoPatioRG --name mapeamentopatioapi2025 --query defaultHostName -o tsv
