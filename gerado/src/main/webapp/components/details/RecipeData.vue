<template><v-card-title ></v-card-title><h1 id="recipeData.name">{{ recipeData.name }}</h1><v-divider ></v-divider><v-list-item ></v-list-item><v-list-item-content ></v-list-item-content><v-row ></v-row><v-col ></v-col><v-text-field ></v-text-field><div id="recipeData.preparation.preparation_time">{{ recipeData.preparation.preparation_time }}</div><b id="vuetify">{{ vuetify }}</b><v-list-item-content ></v-list-item-content><v-list-item ></v-list-item><h3 id="vuetify">{{ vuetify }}</h3><v-divider ></v-divider><v-list-item-content ></v-list-item-content><span id="ingredient.quantity">{{ ingredient.quantity }}</span><b id="ingredient.quantity">{{ ingredient.quantity }}</b><v-list-item-content ></v-list-item-content><v-list-item ></v-list-item><v-divider ></v-divider><v-list-item-content ></v-list-item-content><h3 id="vuetify">{{ vuetify }}</h3><b id="vuetify">{{ vuetify }}</b><span id="step.description">{{ step.description }}</span>
	</template>

<script>
export default {
    name: 'recipe-data',
	
	data: 
	{
		return {servings : 0}
	},	
	methods:
	{		
		
	}
}
</script>