# Maui.Graphics

[![Website](https://github.com/swharden/Maui.Graphics/actions/workflows/website.yaml/badge.svg)](https://github.com/swharden/Maui.Graphics/actions/workflows/website.yaml)

**This repository contains source code for the https://maui.graphics website.** [Microsoft.Maui.Graphics](https://github.com/dotnet/Microsoft.Maui.Graphics) is a 2D graphics library developed by Microsoft as part of the [.NET MAUI project](https://github.com/dotnet/maui). It can be used to create 2D graphics in most .NET projects (not just MAUI apps).

**Purpose of this website:** Developers searching for documentation may type `Microsoft.Maui.Graphics` in the address bar intending to perform a web search. Since `.graphics` is a top level domain, this action results in a HTTP request which eventually times-out and displays an error message. The domain name [maui.graphics](https://maui.graphics) was registered so these users will instead be presented with relevant links. 

This repository/website is not affiliated with Microsoft.

## Development Environment

https://maui.graphics is a static site generated from Markdown using [Hugo](https://gohugo.io/).

### Run Locally

* [Download Hugo](https://github.com/gohugoio/hugo/releases) and ensure it is in your PATH
* Open a console to the website folder: `cd website`
* Launch Hugo's development server: `hugo serve`
* Navigate to the URL displayed in the output (e.g., http://localhost:1313)
* The website updates in real time as markdown files are edited

### Deploy
Commits to the `main` branch trigger a GitHub Action that uses Hugo to build the website in the cloud and deploy it using FTP (see [website.yaml](.github/workflows/website.yaml)).