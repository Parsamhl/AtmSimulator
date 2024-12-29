using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Atm.VerificationCode.AppService
{
    public interface IVerificationCodeAppService
    {

        string GenerateAndSaveCode();
        void SaveVerificationCodeToFile(string verificationCode);
        Result.Entitiy.Result ValidateCode(string enteredCode);
    }
}
