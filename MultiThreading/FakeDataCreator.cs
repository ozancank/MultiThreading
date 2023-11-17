using MultiThreading.Models;

namespace MultiThreading;

internal class FakeDataCreator
{
    public static IEnumerable<MailObject> GetMails(int number, MailProviderType? mailProviderType = null)
    {
        var faker = new Bogus.Faker<MailObject>()
            .RuleFor(i => i.To, y => y.Internet.Email())
            .RuleFor(i => i.ProviderType, y => mailProviderType.HasValue
                                                ? mailProviderType
                                                : y.PickRandom<MailProviderType>());

        return faker.Generate(number);
    }
}