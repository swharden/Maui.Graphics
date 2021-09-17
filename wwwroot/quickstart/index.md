---
Title: Maui.Graphics - Windows Forms Quickstart
Description: Draw in a Windows Forms application using Maui.Graphics
Date: 2021-09-10 10:30PM EST
Tags: quickstart, winforms
---

# Maui.Graphics WinForms Quickstart

Do we need simplicity or performance?

![](both.jpg)

wow old school memes

```php
private function getIndexUrls(string $basePath, string $baseUrl, int $maxDepth)
{
    $directoryIterator = new RecursiveDirectoryIterator($basePath, FilesystemIterator::FOLLOW_SYMLINKS);
    $fileIterator = new RecursiveIteratorIterator($directoryIterator);
    $fileIterator->setMaxDepth($maxDepth);
    $urls = [$baseUrl];
    foreach ($fileIterator as $filePath) {
        if (basename($filePath) == "index.md") {
            $urls[] = $baseUrl . dirname(substr($filePath, 1));
        }
    }
    return $urls;
}

private function getSitemapXml(array $urls)
{
    $xml = "";
    $xml .= "<?xml version='1.0' encoding='UTF-8'?>";
    $xml .= "<urlset xmlns='http://www.sitemaps.org/schemas/sitemap/0.9'>";
    foreach ($urls as $url) {
        $xml .= "<url><loc>$url</loc></url>";
    }
    $xml .= "</urlset>";
    return $xml;
}
```