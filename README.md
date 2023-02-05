# Sample .NET App - ASP.NET 6.0

[![CircleCI](https://dl.circleci.com/status-badge/img/gh/lmolotii/woven-challange/tree/main.svg?style=svg)](https://dl.circleci.com/status-badge/redirect/gh/lmolotii/woven-challange/tree/main) [![Software License](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/lmolotii/woven-challange)

## Description

The sample .NET core app here is designed to demonstrate what a typical .NET core CI workflow may look on CircleCI.

You can see the CI pipelines for this application running [live on CircleCI](https://app.circleci.com/pipelines/github/lmolotii/woven-challange?branch=main).

In this sample config, we have a single workflow `Run tests` which will run tests with xunit by running `dotnet test`.

## Getting Started

If you would like to copy the [config.yml](https://github.com/lmolotii/woven-challange/blob/main/.circleci/config.yml) and adapt it to your project, be sure to read the comments in the config file to ensure it works for your project. For more details, see the [CircleCI configuration reference](https://circleci.com/docs/2.0/configuration-reference/).


## About This App

This sample application is a .NET core ASP.NET console application.
