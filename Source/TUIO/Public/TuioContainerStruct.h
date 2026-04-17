#pragma once

#include "CoreMinimal.h"
#include "Math/Vector2D.h"

#include "TUIO/TuioContainer.h"

#include "TuioContainerStruct.generated.h"

USTRUCT(BlueprintType)
struct FTuioContainerStruct
{
	GENERATED_BODY()

	FTuioContainerStruct() = default;
	FTuioContainerStruct(const TUIO::TuioContainer& source);

	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "TuioContainer")
	FVector2D Position;

	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "TuioContainer")
	FVector2D Speed;

	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "TuioContainer")
	float SessionID;

	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "TuioContainer")
	float SourceID;

	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "TuioContainer")
	double Timestamp;
};