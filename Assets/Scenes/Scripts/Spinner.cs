// (c) 2021 Dodgee Software

using UnityEngine;
using System.Collections;

namespace Game.Spinner
{
	public class Spinner : MonoBehaviour
	{
		#region Inspector Fields

		[Tooltip("Degrees per Second for the rotation aka speed")]
		public float DegreesPerSecond = 10.0f;

		#endregion

		#region Fields

		// Keep track of the spinner state
		protected bool isSpinning = false;

		#endregion

		#region MonoBehaviour

		void Update()
		{
			// Is the spinner spinning?
			if (isSpinning == true)
			{
				// Rotate the spinner object
				transform.Rotate(new Vector3(0.0f, 0.0f, DegreesPerSecond) * Time.deltaTime);
			}
		}

		#endregion

		#region Public Methods

		/// <summary>
		/// Start the spinner spinning
		/// </summary>
		public void StartSpinning()
		{
			isSpinning = true;
		}

		/// <summary>
		/// Stop the spinner spinning
		/// </summary>
		public void StopSpinning()
		{
			isSpinning = false;
		}

		/// <summary>
		/// Set the rotation speed in degrees per second
		/// </summary>
		/// <param name="degreesPerSecond"></param>
		public void SetRotationSpeed(float degreesPerSecond)
		{
			DegreesPerSecond = degreesPerSecond;
		}

		#endregion
	}
}