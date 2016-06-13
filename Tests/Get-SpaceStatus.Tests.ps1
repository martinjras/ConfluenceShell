describe "Get-SpaceStatus" {
	
        BeforeAll {
            Add-Space -SpaceKey "a" -Name "b" -Description "c" | Out-Null
        }
	
        AfterAll {
            remove-space "a" -force
        }

	    it "should be able to fetch the space status" {
            $status = Get-SpaceStatus "a"
            $status | Should BeOfType ConfluenceShell.CmdletTypes.SpaceStatus
            $status | Should Be "Current"
	    }
}
