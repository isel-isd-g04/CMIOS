#!/bin/bash

dotnet publish -c Release -r linux-x64 -o out /p:ShowLinkerSizeComparison=true

docker build -t kxpto/cmoi-tmais-service .

docker push kxpto/cmoi-tmais-service

#docker run kxpto/cmoi-tmais-service --name cmoi-tmais