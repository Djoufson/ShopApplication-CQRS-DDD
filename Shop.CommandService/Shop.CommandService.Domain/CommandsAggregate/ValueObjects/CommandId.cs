﻿using Shop.Common.Domain_Layer.Models.Base;

namespace Shop.CommandService.Domain.CommandsAggregate.ValueObjects;

public class CommandId : ValueObject
{
    public Guid Value { get; set; }

    private CommandId(Guid value)
    {
        Value = value;
    }

    public static CommandId CreateUnique() => new (Guid.NewGuid());
    public static CommandId CreateUnique(string id) => new(Guid.Parse(id));
    public override IEnumerable<object> GetEqualityComparer()
    {
        yield return Value;
    }
}
