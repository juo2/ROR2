﻿using System;
using Rewired;
using UnityEngine;

namespace RoR2
{
	// Token: 0x02000581 RID: 1409
	public static class DefaultControllerMaps
	{
		// Token: 0x06001945 RID: 6469 RVA: 0x0006D440 File Offset: 0x0006B640
		[ConCommand(commandName = "export_default_controller_maps", flags = ConVarFlags.None, helpText = "Prints all default Rewired ControllerMaps.")]
		public static void CCExportDefaultControllerMaps(ConCommandArgs args)
		{
			Debug.Log("Joystick Default:");
			Debug.Log(ReInput.mapping.GetJoystickMapInstance(DefaultControllerMaps.xboneControllerGuid, 2, 0).ToXmlString());
			Debug.Log("Joystick UI:");
			Debug.Log(ReInput.mapping.GetJoystickMapInstance(DefaultControllerMaps.xboneControllerGuid, 2, 0).ToXmlString());
			Debug.Log("Keyboard Default:");
			Debug.Log(ReInput.mapping.GetKeyboardMapInstance(0, 0).ToXmlString());
			Debug.Log("Keyboard UI:");
			Debug.Log(ReInput.mapping.GetKeyboardMapInstance(2, 0).ToXmlString());
			Debug.Log("Mouse Default:");
			Debug.Log(ReInput.mapping.GetMouseMapInstance(0, 0).ToXmlString());
			Debug.Log("Mouse UI:");
			Debug.Log(ReInput.mapping.GetMouseMapInstance(2, 0).ToXmlString());
		}

		// Token: 0x04001FA8 RID: 8104
		public const string defaultKeyboardMapString = "<?xml version=\"1.0\" encoding=\"utf-16\"?><KeyboardMap dataVersion=\"2\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/KeyboardMap.xsd\" xmlns=\"http://guavaman.com/rewired\"><sourceMapId>0</sourceMapId><categoryId>0</categoryId><layoutId>0</layoutId><name></name><hardwareGuid>00000000-0000-0000-0000-000000000000</hardwareGuid><enabled>false</enabled><buttonMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>0</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>100</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>0</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>1</axisContribution><keyboardKeyCode>97</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>1</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>119</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>1</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>1</axisContribution><keyboardKeyCode>115</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>4</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>32</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>18</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>306</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>5</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>101</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>6</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>113</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>9</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>304</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>10</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>114</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>19</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>9</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></buttonMaps></KeyboardMap>";

		// Token: 0x04001FA9 RID: 8105
		public const string defaultMouseMapString = "<?xml version=\"1.0\" encoding=\"utf-16\"?><MouseMap dataVersion=\"2\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/MouseMap.xsd\" xmlns=\"http://guavaman.com/rewired\"><sourceMapId>0</sourceMapId><categoryId>0</categoryId><layoutId>0</layoutId><name></name><hardwareGuid>00000000-0000-0000-0000-000000000000</hardwareGuid><enabled>false</enabled><buttonMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>7</actionId><elementType>1</elementType><elementIdentifierId>3</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>8</actionId><elementType>1</elementType><elementIdentifierId>4</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>28</actionId><elementType>1</elementType><elementIdentifierId>5</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></buttonMaps><axisMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>2</actionId><elementType>0</elementType><elementIdentifierId>0</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>3</actionId><elementType>0</elementType><elementIdentifierId>1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></axisMaps></MouseMap>";

		// Token: 0x04001FAA RID: 8106
		public const string defaultJoystickMapString = "<?xml version=\"1.0\" encoding=\"utf-16\"?><JoystickMap dataVersion=\"2\" hardwareGuid=\"d74a350e-fe8b-4e9e-bbcd-efff16d34115\" hardwareName=\"XInput Gamepad\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/JoystickMap.xsd\" xmlns=\"http://guavaman.com/rewired\"><sourceMapId>0</sourceMapId><categoryId>0</categoryId><layoutId>0</layoutId><name></name><hardwareGuid>d74a350e-fe8b-4e9e-bbcd-efff16d34115</hardwareGuid><enabled>false</enabled><buttonMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>4</actionId><elementType>1</elementType><elementIdentifierId>6</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>18</actionId><elementType>1</elementType><elementIdentifierId>14</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>28</actionId><elementType>1</elementType><elementIdentifierId>15</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>6</actionId><elementType>1</elementType><elementIdentifierId>9</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>5</actionId><elementType>1</elementType><elementIdentifierId>8</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>9</actionId><elementType>1</elementType><elementIdentifierId>10</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>10</actionId><elementType>1</elementType><elementIdentifierId>11</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>19</actionId><elementType>1</elementType><elementIdentifierId>12</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></buttonMaps><axisMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>0</actionId><elementType>0</elementType><elementIdentifierId>0</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>1</actionId><elementType>0</elementType><elementIdentifierId>1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>16</actionId><elementType>0</elementType><elementIdentifierId>2</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>17</actionId><elementType>0</elementType><elementIdentifierId>3</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>8</actionId><elementType>0</elementType><elementIdentifierId>4</elementIdentifierId><axisRange>1</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>7</actionId><elementType>0</elementType><elementIdentifierId>5</elementIdentifierId><axisRange>1</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></axisMaps></JoystickMap>";

		// Token: 0x04001FAB RID: 8107
		public const string defaultGamepadTemplateMapString = "<?xml version=\"1.0\" encoding=\"utf-16\"?><ControllerTemplateMap dataVersion=\"1\" templateTypeGuid=\"83b427e4-086f-47f3-bb06-be266abd1ca5\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.0/ControllerTemplateMap.xsd\" xmlns=\"http://guavaman.com/rewired\"><templateTypeGuid>83b427e4-086f-47f3-bb06-be266abd1ca5</templateTypeGuid><enabled>true</enabled><categoryId>0</categoryId><layoutId>0</layoutId><sourceMapId>0</sourceMapId><elementMaps><ControllerTemplateActionAxisMap><elementType>0</elementType><enabled>true</enabled><elementIdentifierId>0</elementIdentifierId><actionId>0</actionId><axisContribution>0</axisContribution><axisRange>0</axisRange><invert>false</invert></ControllerTemplateActionAxisMap><ControllerTemplateActionAxisMap><elementType>0</elementType><enabled>true</enabled><elementIdentifierId>1</elementIdentifierId><actionId>1</actionId><axisContribution>0</axisContribution><axisRange>0</axisRange><invert>false</invert></ControllerTemplateActionAxisMap><ControllerTemplateActionAxisMap><elementType>0</elementType><enabled>true</enabled><elementIdentifierId>2</elementIdentifierId><actionId>16</actionId><axisContribution>0</axisContribution><axisRange>0</axisRange><invert>false</invert></ControllerTemplateActionAxisMap><ControllerTemplateActionAxisMap><elementType>0</elementType><enabled>true</enabled><elementIdentifierId>3</elementIdentifierId><actionId>17</actionId><axisContribution>0</axisContribution><axisRange>0</axisRange><invert>false</invert></ControllerTemplateActionAxisMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>4</elementIdentifierId><actionId>4</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>17</elementIdentifierId><actionId>18</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>8</elementIdentifierId><actionId>6</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>7</elementIdentifierId><actionId>5</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>10</elementIdentifierId><actionId>9</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>11</elementIdentifierId><actionId>8</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>12</elementIdentifierId><actionId>10</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>13</elementIdentifierId><actionId>7</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>14</elementIdentifierId><actionId>19</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap></elementMaps></ControllerTemplateMap>";

		// Token: 0x04001FAC RID: 8108
		private static readonly Guid gamepadTemplateGuid = new Guid("83b427e4-086f-47f3-bb06-be266abd1ca5");

		// Token: 0x04001FAD RID: 8109
		private static readonly Guid xboneControllerGuid = new Guid("19002688-7406-4f4a-8340-8d25335406c8");

		// Token: 0x04001FAE RID: 8110
		public static readonly KeyboardMap defaultKeyboardMap = (KeyboardMap)ControllerMap.CreateFromXml(ControllerType.Keyboard, "<?xml version=\"1.0\" encoding=\"utf-16\"?><KeyboardMap dataVersion=\"2\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/KeyboardMap.xsd\" xmlns=\"http://guavaman.com/rewired\"><sourceMapId>0</sourceMapId><categoryId>0</categoryId><layoutId>0</layoutId><name></name><hardwareGuid>00000000-0000-0000-0000-000000000000</hardwareGuid><enabled>false</enabled><buttonMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>0</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>100</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>0</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>1</axisContribution><keyboardKeyCode>97</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>1</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>119</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>1</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>1</axisContribution><keyboardKeyCode>115</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>4</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>32</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>18</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>306</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>5</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>101</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>6</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>113</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>9</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>304</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>10</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>114</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>19</actionId><elementType>1</elementType><elementIdentifierId>-1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>9</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></buttonMaps></KeyboardMap>");

		// Token: 0x04001FAF RID: 8111
		public static readonly MouseMap defaultMouseMap = (MouseMap)ControllerMap.CreateFromXml(ControllerType.Mouse, "<?xml version=\"1.0\" encoding=\"utf-16\"?><MouseMap dataVersion=\"2\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/MouseMap.xsd\" xmlns=\"http://guavaman.com/rewired\"><sourceMapId>0</sourceMapId><categoryId>0</categoryId><layoutId>0</layoutId><name></name><hardwareGuid>00000000-0000-0000-0000-000000000000</hardwareGuid><enabled>false</enabled><buttonMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>7</actionId><elementType>1</elementType><elementIdentifierId>3</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>8</actionId><elementType>1</elementType><elementIdentifierId>4</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>28</actionId><elementType>1</elementType><elementIdentifierId>5</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></buttonMaps><axisMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>2</actionId><elementType>0</elementType><elementIdentifierId>0</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>3</actionId><elementType>0</elementType><elementIdentifierId>1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></axisMaps></MouseMap>");

		// Token: 0x04001FB0 RID: 8112
		public static readonly ControllerTemplateMap defaultGamepadTemplateMap = ControllerTemplateMap.FromXml("<?xml version=\"1.0\" encoding=\"utf-16\"?><ControllerTemplateMap dataVersion=\"1\" templateTypeGuid=\"83b427e4-086f-47f3-bb06-be266abd1ca5\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.0/ControllerTemplateMap.xsd\" xmlns=\"http://guavaman.com/rewired\"><templateTypeGuid>83b427e4-086f-47f3-bb06-be266abd1ca5</templateTypeGuid><enabled>true</enabled><categoryId>0</categoryId><layoutId>0</layoutId><sourceMapId>0</sourceMapId><elementMaps><ControllerTemplateActionAxisMap><elementType>0</elementType><enabled>true</enabled><elementIdentifierId>0</elementIdentifierId><actionId>0</actionId><axisContribution>0</axisContribution><axisRange>0</axisRange><invert>false</invert></ControllerTemplateActionAxisMap><ControllerTemplateActionAxisMap><elementType>0</elementType><enabled>true</enabled><elementIdentifierId>1</elementIdentifierId><actionId>1</actionId><axisContribution>0</axisContribution><axisRange>0</axisRange><invert>false</invert></ControllerTemplateActionAxisMap><ControllerTemplateActionAxisMap><elementType>0</elementType><enabled>true</enabled><elementIdentifierId>2</elementIdentifierId><actionId>16</actionId><axisContribution>0</axisContribution><axisRange>0</axisRange><invert>false</invert></ControllerTemplateActionAxisMap><ControllerTemplateActionAxisMap><elementType>0</elementType><enabled>true</enabled><elementIdentifierId>3</elementIdentifierId><actionId>17</actionId><axisContribution>0</axisContribution><axisRange>0</axisRange><invert>false</invert></ControllerTemplateActionAxisMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>4</elementIdentifierId><actionId>4</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>17</elementIdentifierId><actionId>18</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>8</elementIdentifierId><actionId>6</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>7</elementIdentifierId><actionId>5</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>10</elementIdentifierId><actionId>9</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>11</elementIdentifierId><actionId>8</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>12</elementIdentifierId><actionId>10</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>13</elementIdentifierId><actionId>7</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap><ControllerTemplateActionButtonMap><elementType>1</elementType><enabled>true</enabled><elementIdentifierId>14</elementIdentifierId><actionId>19</actionId><axisContribution>0</axisContribution></ControllerTemplateActionButtonMap></elementMaps></ControllerTemplateMap>");

		// Token: 0x04001FB1 RID: 8113
		public static readonly JoystickMap defaultJoystickMap = (JoystickMap)ControllerMap.CreateFromXml(ControllerType.Joystick, "<?xml version=\"1.0\" encoding=\"utf-16\"?><JoystickMap dataVersion=\"2\" hardwareGuid=\"d74a350e-fe8b-4e9e-bbcd-efff16d34115\" hardwareName=\"XInput Gamepad\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:schemaLocation=\"http://guavaman.com/rewired http://guavaman.com/schemas/rewired/1.1/JoystickMap.xsd\" xmlns=\"http://guavaman.com/rewired\"><sourceMapId>0</sourceMapId><categoryId>0</categoryId><layoutId>0</layoutId><name></name><hardwareGuid>d74a350e-fe8b-4e9e-bbcd-efff16d34115</hardwareGuid><enabled>false</enabled><buttonMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>4</actionId><elementType>1</elementType><elementIdentifierId>6</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>18</actionId><elementType>1</elementType><elementIdentifierId>14</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>28</actionId><elementType>1</elementType><elementIdentifierId>15</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>6</actionId><elementType>1</elementType><elementIdentifierId>9</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>5</actionId><elementType>1</elementType><elementIdentifierId>8</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>9</actionId><elementType>1</elementType><elementIdentifierId>10</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>10</actionId><elementType>1</elementType><elementIdentifierId>11</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>19</actionId><elementType>1</elementType><elementIdentifierId>12</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></buttonMaps><axisMaps><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>0</actionId><elementType>0</elementType><elementIdentifierId>0</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>1</actionId><elementType>0</elementType><elementIdentifierId>1</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>16</actionId><elementType>0</elementType><elementIdentifierId>2</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>17</actionId><elementType>0</elementType><elementIdentifierId>3</elementIdentifierId><axisRange>0</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>8</actionId><elementType>0</elementType><elementIdentifierId>4</elementIdentifierId><axisRange>1</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap><ActionElementMap><actionCategoryId>0</actionCategoryId><actionId>7</actionId><elementType>0</elementType><elementIdentifierId>5</elementIdentifierId><axisRange>1</axisRange><invert>false</invert><axisContribution>0</axisContribution><keyboardKeyCode>0</keyboardKeyCode><modifierKey1>0</modifierKey1><modifierKey2>0</modifierKey2><modifierKey3>0</modifierKey3><enabled>true</enabled></ActionElementMap></axisMaps></JoystickMap>");
	}
}
