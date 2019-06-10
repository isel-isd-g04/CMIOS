#!/bin/bash

dotnet publish -c Release -r linux-x64 -o out /p:ShowLinkerSizeComparison=true

docker build -t kxpto/cmoi-validation-service .

docker push kxpto/cmoi-validation-service

#docker run kxpto/cmoi-validation-service --name cmoi-validation