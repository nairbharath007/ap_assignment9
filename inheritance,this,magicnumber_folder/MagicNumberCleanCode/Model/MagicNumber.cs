using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumberCleanCode.Model
{

    enum TrafficLightState   //meaningful enum(const) values 
    {
        Stopped,
        Caution,
        Go
    }

    class TrafficLight
    {
        //constants for magic values
        private const int DefaultTransitionTimeInSeconds = 2;
        private const int DefaultCautionTimeInSeconds = 1;

        private TrafficLightState currentState;

        public TrafficLight()
        {
            currentState = TrafficLightState.Stopped;
        }

        public void ChangeState()
        {
            switch (currentState)
            {
                case TrafficLightState.Stopped:
                    TransitionTo(TrafficLightState.Go, DefaultTransitionTimeInSeconds);
                    break;
                case TrafficLightState.Caution:
                    TransitionTo(TrafficLightState.Stopped, DefaultCautionTimeInSeconds);
                    break;
                case TrafficLightState.Go:
                    TransitionTo(TrafficLightState.Caution, DefaultTransitionTimeInSeconds);
                    break;
            }
        }

        private void TransitionTo(TrafficLightState newState, int durationInSeconds)
        {
            Console.WriteLine($"Changing state from {currentState} to {newState}. Please wait {durationInSeconds} seconds.");
            System.Threading.Thread.Sleep(durationInSeconds * 1000); // Simulate the passage of time
            currentState = newState;
        }

        public TrafficLightState GetCurrentState()
        {
            return currentState;
        }


    }
}

