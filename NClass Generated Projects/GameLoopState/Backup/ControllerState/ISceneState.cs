using System;
using System.Collections.Generic;
using System.Text;

namespace GameLoopState.ControllerState
{
	public interface ISceneState
	{
		virtual void StateBegin();

		virtual void StateEnd();

		virtual void StateUpdate();
	}
}
