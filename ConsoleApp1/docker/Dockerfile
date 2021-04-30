FROM microsoft/mssql-server-linux:latest

COPY . /usr/src/docker

WORKDIR /usr/src/docker

RUN chmod +x ./init.sh

CMD /bin/bash ./entrypoint.sh