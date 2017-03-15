#!/bin/bash

DIR="$(dirname "${BASH_SOURCE[0]}")"

cd $DIR
dotnet restore
dotnet build