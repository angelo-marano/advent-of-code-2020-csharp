namespace workspace.Utils
{
	public struct PasswordPolicy
	{
		private readonly int _positionOne;
		private readonly int _positionTwo;
		private readonly char _character;
		private readonly string _password;

		public PasswordPolicy(string policyString)
		{
			var split = policyString.Split(' ');
			var splitRange = split[0].Split('-');
			_positionOne = int.Parse(splitRange[0]);
			_positionTwo = int.Parse(splitRange[1]);

			_character = split[1][0];
			_password = split[2];
		}

		public bool IsValid
		{
			get
			{
				var count = 0;

				for (var i = 0; i < _password.Length; i++)
				{
					if (_password[i] == _character)
						count++;
				}

				return count <= _positionTwo && count >= _positionOne;
			}
		}

		public bool IsValidForAdvancedRules
		{
			get
			{
				var positionOneValid = _password[_positionOne - 1] == _character;
				var positionTwoValid = _password[_positionTwo - 1] == _character;

				return positionOneValid ^ positionTwoValid;
			}
		}

	}
}