<#
.SYNOPSIS
  Run the GitHub Actions workflow locally with act.

.DESCRIPTION
  This script runs a fixed `act` command to simulate a GitHub Actions `push` event.
  It maps `ubuntu-latest` to the `catthehacker/ubuntu:act-latest` Docker image
  and injects a dummy secret for `ACTION_DEPLOY_KEY`.

.EXAMPLE
  ./RunGithubWorkFlowLocally.ps1

  Runs:
    act push -P ubuntu-latest=catthehacker/ubuntu:act-latest -s ACTION_DEPLOY_KEY="FAKE_KEY_FOR_LOCAL_TEST"

.NOTES
  Dependencies:
    - Docker (Desktop or compatible)
    - act (installed and on PATH)
    - PowerShell 7+ (if you want to run pwsh as the shell)

  This will not deploy anything to GitHub Pages when run locally,
  because the secret is a dummy value. It only ensures the workflow
  can be tested end-to-end.
#>


act push -P ubuntu-latest=catthehacker/ubuntu:act-latest -s ACTION_DEPLOY_KEY="FAKE_KEY_FOR_LOCAL_TEST"