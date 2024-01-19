﻿using DogSearch.Core.Entities.Dog;
using MediatR;
namespace DogSearch.Core.Commands;

public class DeleteDogCommand : IRequest
{
    public DeleteDogCommand(Guid id)
    {
        Id = new DogId(id);
    }

    public DogId Id { get; init; }
}