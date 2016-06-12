describe "Remove-Space" {
	
    context "when -force is specified" {

        BeforeEach {
            Add-Space -SpaceKey "a" -Name "b" -Description "c" | Out-Null
        }
	
	    it "should remove the space" {
            Remove-Space -SpaceKey "a" -force
            $space = Get-Space -SpaceKey "a" -ErrorAction SilentlyContinue
		    $space.SpaceKey | should Be $null
	    }
    }
}
