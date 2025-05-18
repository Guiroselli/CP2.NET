
# Build da imagem Docker
docker build -t seuusuariodocker/mapepatio:latest ./MapeamentoInteligentePatio.API

# Login no Docker Hub
docker login

# Push para o Docker Hub
docker push seuusuariodocker/mapepatio:latest
