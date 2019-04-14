#!/bin/bash

./protoc -I="." --csharp_out=../SharedModels/csharp UserData.proto Validation.proto RemoteServer.proto
./protoc -I="." --java_out=../SharedModels/java UserData.proto Validation.proto
./protoc -I="." --cpp_out=../SharedModels/cpp UserData.proto Validation.proto