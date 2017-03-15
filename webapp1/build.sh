#!/bin/bash

DIR="$(dirname "${BASH_SOURCE[0]}")"

echo DIR=$DIR
cd $DIR
pwd
dotnet restore
dotnet build