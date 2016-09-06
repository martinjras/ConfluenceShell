# ConfluenceShell #

## A PowerShell approach to administering Atlassian Confluence ##

This project enables you to do administrative tasks in Confluence using PowerShell

**Builds on exisiting technology**

ConfluenceShell is simply a wrapper around the existing XML-RPC API in Confluence.

Atlassian is actually discontinuing the XML-RPC API, to be replaced by a new REST API. 

So you might be wondering: why the F*** then use XML-RPC API?

Well....the new REST API simply doesn't have the same functionality as the XML-RPC API yet. That's why :)

When Atlassian has implemented the same features in the REST API, it should be quite simple to point ConfluenceShell to that one.


## Made in TFS ##