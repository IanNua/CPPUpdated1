// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "TimeFunc.generated.h"

UCLASS()
class CPPUPDATED1_API ATimeFunc : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	ATimeFunc();

	UFUNCTION(BlueprintCallable, meta = (WorldContext = "TimerGoUp"))
	void HandleTimer();

	FTimerHandle MyHandle;

	int number = 1;

protected:
	// Called when the game starts or when spawned
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void Tick(float DeltaTime) override;

};
