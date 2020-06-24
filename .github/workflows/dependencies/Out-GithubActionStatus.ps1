<#

.SYNOPSIS
    Reads the output.json file and outputs status to GitHub Actions

.DESCRIPTION
    Reads the output.json file and outputs status to GitHub Actions

.INPUTS
    None

.OUTPUTS
    None

.NOTES
    Version:        1.1
    Author:         adegeo@microsoft.com
    Creation Date:  06/24/2020
    Purpose/Change: Change reporting items.
#>

[CmdletBinding()]
Param(
)

$json = Get-Content output.json | ConvertFrom-Json

$errors = $json | Where-Object ErrorCount -ne 0 | Select-Object InputFile -ExpandProperty Errors | Select-Object InputFile, Error, Line

if ($errors.Count -eq 0) {
    Write-Host "All builds passed"
    exit 0
}

Write-Host "Total errors: $($errors.Count)"

foreach ($er in $errors) {

    $lineColMatch = Select-String "\((\d*),(\d*)\)" | Select-Object -ExpandProperty Matches | Select-Object -ExpandProperty Groups
    $lineNumber = 0
    $colNumber = 0

    if ($lineColMatch.Count -eq 3) {
        $lineNumber = $lineColMatch[1].Value
        $colNumber = $lineColMatch[2].Value
    }

    Write-Host "::error file=$($er.InputFile),line=$lineNumber,col=$colNumber::----FILE:  $($er.InputFile)`n    ERROR: $($er.Error)`n    LINE:  $($er.Line)"
}

exit 1