<?php
header('Content-Type: application/json');

require_once __DIR__ . '/../../config/config.php';
try {
    $stmt = $pdo->prepare("SELECT id, date, activity, duration, intensity, notes FROM activities ORDER BY date ASC");
    $stmt->execute();
    $exercises = $stmt->fetchAll(PDO::FETCH_ASSOC);
    if ($exercises) {
        $content = [];
        foreach ($exercises as $exercise) {
            $content[] = [
                "id" => $exercise["id"],
                "date" => $exercise["date"],
                "activity" => $exercise["activity"],
                "duration" => $exercise["duration"],
                "intensity" => $exercise["intensity"],
                "notes" => substr($exercise["notes"], 0, 100) . (strlen($exercise["notes"]) > 100 ? '...' : '')
            ];
        }
        echo json_encode([
            "success" => true,
            "data" => $content
        ]);
    } else {
        echo json_encode([
            "success" => false,
        ]);
    }
} catch (PDOException $e) {
    echo json_encode([
        "success" => false,
        "message" => "Database query failed: " . $e->getMessage()
    ]);
}
?>