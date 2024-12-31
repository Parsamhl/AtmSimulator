using App.Domain.Core.Atm.Result.Entitiy;
using App.Domain.Core.Atm.VerificationCode.AppService;
using App.infra.VerificationTxtFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Atm.Verification_code
{
    internal class VerifiCationCodeAppService : IVerificationCodeAppService
    {
        private readonly VerificationCodeTxtFile _verificationCodeFilePath;

        public VerifiCationCodeAppService()
        {
            _verificationCodeFilePath = new VerificationCodeTxtFile();
        }

        public string GenerateAndSaveCode()
        {
            var verificationCode = new Random().Next(10000, 99999).ToString();


            SaveVerificationCodeToFile(verificationCode);

            return verificationCode;
        }

        public void SaveVerificationCodeToFile(string verificationCode)
        {
            using (StreamWriter writer = new StreamWriter(_verificationCodeFilePath.FilePath, false))
            {
                writer.WriteLine(verificationCode);
                writer.WriteLine(DateTime.Now);
            }
        }

        public Result ValidateCode(string enteredCode)
        {
            if (File.Exists(_verificationCodeFilePath.FilePath))
            {
                var lines = File.ReadAllLines(_verificationCodeFilePath.FilePath);
                string storedCode = lines[0];
                DateTime timestamp = DateTime.Parse(lines[1]);


                if (storedCode == enteredCode && DateTime.Now - timestamp <= TimeSpan.FromMinutes(5))
                {
                    return new Result { IsSuccess = true };
                }
            }
            return new Result { IsSuccess = false, Erorr = "Code is not valid!" };
        }
    }
}
