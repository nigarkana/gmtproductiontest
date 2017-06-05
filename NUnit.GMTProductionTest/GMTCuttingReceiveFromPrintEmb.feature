Feature: GMTCuttingReceiveFromPrintEmb
	Recieve From Print/Emb from Print

@mytag
Scenario: Cutting -> Receive from Print/Emb
	Given Login, Menu link, Job Code
	When press View, Check select Option, click Receive
	Then Receive from Print/Emb saved successfully
