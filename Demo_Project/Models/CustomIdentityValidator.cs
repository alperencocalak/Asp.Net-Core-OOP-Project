using Microsoft.AspNetCore.Identity;

namespace Demo_Project.Models
{
    public class CustomIdentityValidator: IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = "Parola En Az 6 Karakter Olmalıdır."

            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description = "Parola En Az 1 Tane Büyük Harf İçermelidir"
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresLower",
                Description = "Parola En Az 1 Küçük Karakter İçermelidir."
            };
        }
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola En Az 1 Alfanümerik Karakter İçermelidir."
            };
        
        }
    }
}
