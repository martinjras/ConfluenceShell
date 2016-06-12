describe "Add-Space" {
	
	beforeEach {
		#remove-space -SpaceKey "a" -Force -ErrorAction SilentlyContinue | out-null
	}
	
	afterEach {
		#remove-space -SpaceKey "a" -Force -ErrorAction SilentlyContinue | out-null
	}
	
	Add-Space -SpaceKey "a" -Name "b" -Description "c" | Out-Null
	$space = Get-Space -SpaceKey "a"
	
	it "should set space properties" {
		$space.SpaceKey 	| should be "a"
		$space.Name 		| should be "b"
		$space.Description 	| should be "c"
		$space.HomePage		| should BeOfType System.Int64
		$space.Url 			| should Not BeNullOrEmpty
	}
}
