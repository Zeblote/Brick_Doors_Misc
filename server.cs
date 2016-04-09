if( forceRequiredAddOn("Support_Doors") == $Error::AddOn_NotFound ) {
	error("ERROR: Support_Doors missing!");
	return;
}



//Boom Barrier
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
datablock fxDTSBrickData ( brickDoorBoomBarrierOpenCWData )
{
	brickFile = "./resources/boombarrier/boombarrier_open_cw.blb";
	uiName = "Boom Barrier";
	
	isDoor = 1;
	isOpen = 1;
	
	closedCW = "brickDoorBoomBarrierCWData";
	openCW = "brickDoorBoomBarrierOpenCWData";
	
	closedCCW = "brickDoorBoomBarrierCCWData";
	openCCW = "brickDoorBoomBarrierOpenCCWData";
};

datablock fxDTSBrickData ( brickDoorBoomBarrierCCWData : brickDoorBoomBarrierOpenCWData )
{
	brickFile = "./resources/boombarrier/boombarrier_closed_ccw.blb";	
	isOpen = 0;
};

datablock fxDTSBrickData ( brickDoorBoomBarrierOpenCCWData : brickDoorBoomBarrierOpenCWData )
{
	brickFile = "./resources/boombarrier/boombarrier_open_ccw.blb";
	isOpen = 1;
};

datablock fxDTSBrickData ( brickDoorBoomBarrierCWData : brickDoorBoomBarrierOpenCWData )
{
	brickFile = "./resources/boombarrier/boombarrier_closed_cw.blb";	
	isOpen = 0;

	category = "Special";
	subCategory = "Doors";
	iconName = "Add-Ons/Brick_Doors_Misc/resources/boombarrier/boombarrier";
};



//Target Vertical
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
datablock fxDTSBrickData ( brickDoorTargetVerticalOpenCWData )
{
	brickFile = "./resources/target/target_vertical_open.blb";
	uiName = "Target (Vertical)";
	
	isDoor = 1;
	isOpen = 1;
	
	closedCW = "brickDoorTargetVerticalCWData";
	openCW = "brickDoorTargetVerticalOpenCWData";
	
	closedCCW = "brickDoorTargetVerticalCWData";
	openCCW = "brickDoorTargetVerticalOpenCWData";
};

datablock fxDTSBrickData ( brickDoorTargetVerticalCWData : brickDoorTargetVerticalOpenCWData )
{
	brickFile = "./resources/target/target_vertical_closed.blb";
	isOpen = 0;

	category = "Special";
	subCategory = "Doors";
	iconName = "Add-Ons/Brick_Doors_Misc/resources/target/target_vertical";
};



//Target Horizontal
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
datablock fxDTSBrickData ( brickDoorTargetHorizontalOpenCWData )
{
	brickFile = "./resources/target/target_horizontal_open.blb";
	uiName = "Target (Horizontal)";
	
	isDoor = 1;
	isOpen = 1;
	
	closedCW = "brickDoorTargetHorizontalCWData";
	openCW = "brickDoorTargetHorizontalOpenCWData";
	
	closedCCW = "brickDoorTargetHorizontalCWData";
	openCCW = "brickDoorTargetHorizontalOpenCWData";
};

datablock fxDTSBrickData ( brickDoorTargetHorizontalCWData : brickDoorTargetHorizontalOpenCWData )
{
	brickFile = "./resources/target/target_horizontal_closed.blb";
	isOpen = 0;

	category = "Special";
	subCategory = "Doors";
	iconName = "Add-Ons/Brick_Doors_Misc/resources/target/target_horizontal";
};



//Piston Horizontal
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
datablock fxDTSBrickData ( brickDoorPistonHorizontalOpenCWData )
{
	brickFile = "./resources/piston/piston_horizontal_open.blb";
	uiName = "Piston (Horizontal)";
	
	isDoor = 1;
	isOpen = 1;
	
	closedCW = "brickDoorPistonHorizontalCWData";
	openCW = "brickDoorPistonHorizontalOpenCWData";
	
	closedCCW = "brickDoorPistonHorizontalCWData";
	openCCW = "brickDoorPistonHorizontalOpenCWData";
};

datablock fxDTSBrickData ( brickDoorPistonHorizontalCWData : brickDoorPistonHorizontalOpenCWData )
{
	brickFile = "./resources/piston/piston_horizontal_closed.blb";
	isOpen = 0;

	category = "Special";
	subCategory = "Doors";
	iconName = "Add-Ons/Brick_Doors_Misc/resources/piston/piston_horizontal";
};



//Piston Horizontal 2x
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
datablock fxDTSBrickData ( brickDoorPistonHorizontal2xOpenCWData )
{
	brickFile = "./resources/piston/piston_horizontal_2x_open.blb";
	uiName = "Piston 2x (Horizontal)";
	
	isDoor = 1;
	isOpen = 1;
	
	closedCW = "brickDoorPistonHorizontal2xCWData";
	openCW = "brickDoorPistonHorizontal2xOpenCWData";
	
	closedCCW = "brickDoorPistonHorizontal2xCWData";
	openCCW = "brickDoorPistonHorizontal2xOpenCWData";
};

datablock fxDTSBrickData ( brickDoorPistonHorizontal2xCWData : brickDoorPistonHorizontal2xOpenCWData )
{
	brickFile = "./resources/piston/piston_horizontal_2x_closed.blb";
	isOpen = 0;

	category = "Special";
	subCategory = "Doors";
	iconName = "Add-Ons/Brick_Doors_Misc/resources/piston/piston_horizontal_2x";
};


