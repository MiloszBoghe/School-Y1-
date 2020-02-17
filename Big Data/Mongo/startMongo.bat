@echo off
cd C:\Program Files\MongoDB\Server\4.0\bin
start mongod.exe
timeout /t 2
start mongo.exe
