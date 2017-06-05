Feature: GMTCutting-QCAfterPrintEmb
	QC After Print/Emb

@mytag
Scenario: QC after Print/Emb (Cutting)
	Given Login, Menu Link, Job Code and press enter
	When click on row, enter QC pass, reject, remarks, click Select option and Save
	Then the result should be 120 on the screen
