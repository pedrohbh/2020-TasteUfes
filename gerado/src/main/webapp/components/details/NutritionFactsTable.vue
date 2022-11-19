<template><v-sheet ></v-sheet><v-skeleton-loader ></v-skeleton-loader><v-card-title ></v-card-title><v-row ></v-row><v-col ></v-col><v-card-text ></v-card-text><v-divider ></v-divider><span id="servings">{{ servings }}</span><h3 id="vuetify">{{ vuetify }}</h3><span id="data.serving_size">{{ data.serving_size }}</span><v-divider ></v-divider><v-row ></v-row><v-col ></v-col><h2 id="vuetify">{{ vuetify }}</h2><span id="parseInt(data.serving_energy)">{{ parseInt(data.serving_energy) }}</span><h3 id="vuetify">{{ vuetify }}</h3><span id="getDailyValue(data.daily_value)">{{ getDailyValue(data.daily_value) }}</span><v-divider ></v-divider><v-row ></v-row><v-col ></v-col><h5 id="vuetify">{{ vuetify }}</h5><v-col ></v-col><h5 id="nutrition_facts_nutrient.nutrient.name">{{ nutrition_facts_nutrient.nutrient.name }}</h5><v-divider ></v-divider><span id="getDailyValue(data.daily_value)">{{ getDailyValue(data.daily_value) }}</span>
	</template>

<script>
export default {
    name: 'nutrition-facts-table',
	
	data: 
	{
		return {data : { type: Object }}
	},	
	methods:
	{		
		
		getDailyValue(String valor) 
		{
			//TODO To be implemented
		}
		
	}
}
</script>