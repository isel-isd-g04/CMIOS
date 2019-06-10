FROM microsoft/aspnetcore AS runtime

WORKDIR /app
#COPY bin/Release/netcoreapp2.2/linux-x64 /app/ 
COPY out/ /app/ 
RUN chmod +x TMAISRemoteAPI.dll

ENV ASPNETCORE_ENVIRONMENT Local  

ENTRYPOINT ["dotnet", "TMAISRemoteAPI.dll"]