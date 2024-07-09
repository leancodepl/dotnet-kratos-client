#!/usr/bin/env zsh

cd "${0:A:h}" || exit 1

exec openapi-generator-cli generate --config ./LeanCode.Kratos.Client.json