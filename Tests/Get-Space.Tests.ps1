describe "Get-Space" {
	
        BeforeAll {
            Add-Space -SpaceKey "a" -Name "b" -Description "c" | Out-Null
            Add-Space -SpaceKey "b" -Name "c" -Description "d" | Out-Null
        }
	
        AfterAll {
            "a","b" | remove-space -force
        }

	    it "should fetch a single space when space key is defined" {
            (Get-Space -SpaceKey "a").Count | Should Be 1
	    }

	    it "should fetch all spaces when no space key is defined" {
            (Get-Space).Count | Should BeGreaterThan 1
	    }

	    it "should throw an error if a space does not exist" {
            Get-Space -SpaceKey "z" -ea silent | Should Throw
	    }
}
