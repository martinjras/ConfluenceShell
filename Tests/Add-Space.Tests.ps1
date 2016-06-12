describe "Add-Space" {
	
	beforeAll {
		remove-space -SpaceKey "a" -Force -ErrorAction SilentlyContinue
	}
	
	afterAll {
		remove-space -SpaceKey "a" -Force -ErrorAction SilentlyContinue
	}
	
	it "should set space properties" {
        Add-Space -SpaceKey "a" -Name "b" -Description "c" | Out-Null
	    $space = Get-Space -SpaceKey "a"
		$space.SpaceKey 	| should be "a"
		$space.Name 		| should be "b"
		$space.Description 	| should be "c"
		$space.HomePage		| should BeOfType System.Int64
		$space.Url 			| should Not BeNullOrEmpty
	}
}
