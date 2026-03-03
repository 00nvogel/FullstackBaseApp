using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BaseBackend.Shared;

namespace BaseBackend.Domain.Events;

public record ExampleEvent(DateTime OccurredOnUtc, string Message) : IDomainEvent;
