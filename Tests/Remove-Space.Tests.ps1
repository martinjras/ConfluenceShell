describe "Remove-Space" {
	
    context "when -force is specified" {

        Add-Space -SpaceKey "a" -Name "b" -Description "c" | Out-Null

	    Remove-Space -SpaceKey "a" 
        
        $space = Get-Space -SpaceKey "a" -ErrorAction SilentlyContinue
	
	    it "should remove the space" {
		    $space.SpaceKey | should Be $null
	    }
    }
}
